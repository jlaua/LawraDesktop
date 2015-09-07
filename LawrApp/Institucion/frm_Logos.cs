using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Custom's
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Threading;
using Objects.Tables;
using Institution;
using Options;

namespace LawrApp.Institucion
{
	public partial class frm_Logos : MetroForm
	{
		PictureBox _ptbSelected = new PictureBox();

		private List<tMinLogos> _minLogos = new List<tMinLogos>();
		private List<tLogos> _lLogos = new List<tLogos>();

		private Logos _lg = new Logos();

		private Thread _hilo;
		private bool _inAction = false;
		private int _codigoLogo = 0;

		public frm_Logos()
		{
			InitializeComponent();
		}

		#region THREAD'S

		void LoadData()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._lLogos = this._lg.Listar();

			if ( this._lLogos != null )
			{
				if ( this._lLogos.Any() )
				{
					string urlBase = this._lg.getAppSettings("BaseUrl");

					foreach( tLogos item in this._lLogos )
					{
						string src = string.Format( "{0}{1}{2}_sm{3}", urlBase, item.Source, item.Name, item.Extension );

						if ( item.Dimension == 1 && item.Type == 1 ) this.ptbLogo_Color_Square.ImageLocation = src;
						else if ( item.Dimension == 2 && item.Type == 1 ) this.ptbLogo_Color_Rectangle.ImageLocation = src;
						else if ( item.Dimension == 1 && item.Type == 2 ) this.ptbLogo_Grey_Square.ImageLocation = src;
						else if ( item.Dimension == 2 && item.Type == 2 ) this.ptbLogo_Grey_Rectangle.ImageLocation = src;
						else if ( item.Dimension == 1 && item.Type == 3 ) this.ptbLogo_Black_Square.ImageLocation = src;
						else if ( item.Dimension == 2 && item.Type == 3 ) this.ptbLogo_Black_Rectangle.ImageLocation = src;
						else if ( item.Dimension == 1 && item.Type == 4 ) this.ptbLogo_White_Square.ImageLocation = src;
						else if ( item.Dimension == 2 && item.Type == 4 ) this.ptbLogo_White_Rectangle.ImageLocation = src;
					}

					pgsLoading.Visible = false;
					panelMain.Enabled = true;
				}
				else
				{
					pgsLoading.Visible = false;
					MetroMessageBox.Show( this, "NO EXISTEN LOGOS ASOCIADOS A LA INSTITUCIÓN", "NO SE ENCONTRARON LOGOS", MessageBoxButtons.OK, MessageBoxIcon.Warning );
					this.panelMain.Enabled = true;
				}
			}

			this._hilo.Abort();
		}

		void SaveImagesLogos()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;
			string status;
			
			List<tMinLogos> tmpMin = new List<tMinLogos>();

			foreach( tMinLogos tmp in this._minLogos )
			{
				tLogos objExist = this._lLogos.Find( x => x.Dimension == tmp.Dimension && x.Type == tmp.Type );
				tLogos respLogo = new tLogos();

				this._lg.Data = tmp;

				status = ( objExist == null ) ? "Registrando" : "Modificando ";

				if ( tmp.Type == 1 && tmp.Dimension == 1 ) this.lblStatus.Text = status + " Logo Cuadrado de Tipo Color";
				else if ( tmp.Dimension == 2 && tmp.Type == 1 ) this.lblStatus.Text = status + " Logo Rectangular de Tipo Color";
				else if ( tmp.Dimension == 1 && tmp.Type == 2 ) this.lblStatus.Text = status + " Logo Cuadrado de Tipo Gris";
				else if ( tmp.Dimension == 2 && tmp.Type == 2 ) this.lblStatus.Text = status + " Logo Rectangular de Tipo Gris";
				else if ( tmp.Dimension == 1 && tmp.Type == 3 ) this.lblStatus.Text = status + " Logo Cuadrado de Tipo Negro";
				else if ( tmp.Dimension == 2 && tmp.Type == 3 ) this.lblStatus.Text = status + " Logo Rectangular de Tipo Negro";
				else if ( tmp.Dimension == 1 && tmp.Type == 4 ) this.lblStatus.Text = status + " Logo Cuadrado de Tipo Blanco";
				else if ( tmp.Dimension == 2 && tmp.Type == 4 ) this.lblStatus.Text = status + " Logo Rectangular de Tipo Blanco";

				if ( objExist == null ) respLogo = this._lg.Insert();
				else respLogo = this._lg.Update( objExist.Codigo );

				if ( respLogo != null )
				{
					int index = this._lLogos.FindIndex( x => x.Dimension == respLogo.Dimension && x.Type == respLogo.Type );
					if ( index >= 0 ) this._lLogos[index] = respLogo;
					else this._lLogos.Add( respLogo );
					
					tmpMin.Add( tmp );

					this.lblStatus.Text = "El logo ha Sido " + ( ( objExist == null ) ? "Registrado" : "Modificado") + "Con Exito";
				}
			}

			pgsLoading.Visible = false;
			this.panelMain.Enabled = true;

			foreach( tMinLogos item in tmpMin )
			{
				this._minLogos.Remove( item );
			}

			if ( ! this._minLogos.Any() )
			{
				this._minLogos = new List<tMinLogos>();
				this.btnGuardar.Enabled = false;
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		void DeleteImageLogos()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			if ( this._lg.Delete( this._codigoLogo ) )
			{

			}

			this._inAction = false;
			this._hilo.Abort();
		}

		#endregion

		#region METODOS

		private void LoadImageToPictureBox( PictureBox img )
		{
			this.OpenFile.Filter = "Images | *.jpg; *.png; *.jpeg";

			DialogResult result = this.OpenFile.ShowDialog();

			if ( result == DialogResult.OK )
			{
				string src = this.OpenFile.FileName;

				System.IO.FileInfo info = new System.IO.FileInfo( src );

				if ( ( info.Length / 1048576 ) < 1.5 )
				{
					img.Load( src );

					tMinLogos lg = new tMinLogos();

					string[] relation = ( ( string ) img.Tag ).Split( '-' );

					lg.Type = Convert.ToInt32( relation[0] );
					lg.Dimension = Convert.ToInt32( relation[1] );
					lg.Handle = Helper.NameImageRandom( 15 );
					lg.Source = src;

					int indexExists = this._minLogos.FindIndex( x => x.Dimension == lg.Dimension && x.Type == lg.Type );

					if ( indexExists < 0 )
						this._minLogos.Add( lg );
					else
						this._minLogos[indexExists] = lg;

					this.btnGuardar.Enabled = true;
				}
				else
				{
					MetroMessageBox.Show( this, "El Tamaño maximo para una imagen es de 1.5MB.", "LA imagen a superado el tamaño Maximo", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				}
			}
		}

		#endregion

		private void frm_Logos_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.LoadData ) );

			this.panelMain.Enabled = false;
			this.pgsLoading.Visible = true;

			this._hilo.Start();
		}

		private void RightClick_PictureBox_MouseDown( object sender, MouseEventArgs e )
		{
			PictureBox img = ( PictureBox ) sender;

			if ( e.Button == MouseButtons.Right )
			{
				this._ptbSelected = img;
				this.cmsImage.Show( img, e.X, e.Y );
			}
			else if ( e.Button == MouseButtons.Left )
			{
				this.LoadImageToPictureBox( img );
			}
		}

		private void tsmiClear_Click( object sender, EventArgs e )
		{
			string[] relation = ( ( string ) this._ptbSelected.Tag ).Split( '-' );
			
			int type = Convert.ToInt32( relation[0] );
			int dimension = Convert.ToInt32( relation[1] );

			int posLocal = this._minLogos.FindIndex( x => x.Dimension == dimension && x.Type == type );
			tLogos objRemote = this._lLogos.Find( x => x.Dimension == dimension && x.Type == type );

			if ( posLocal >= 0 && objRemote != null )
			{
				this._minLogos.RemoveAt( posLocal );
				this._ptbSelected.ImageLocation = string.Format("{0}{1}{2}_sm{3}", this._lg.getAppSettings("BaseUrl"), objRemote.Source, objRemote.Name, objRemote.Extension );
			}
			else if ( posLocal >= 0 && objRemote == null )
			{
				this._minLogos.RemoveAt( posLocal );
				this._ptbSelected.ImageLocation = null;
			}

			if ( !this._minLogos.Any() ) this.btnGuardar.Enabled = false;
		}

		private void tsmiAddImage_Click( object sender, EventArgs e )
		{
			this.LoadImageToPictureBox( this._ptbSelected );
		}

		private void btnGuardar_Click( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( SaveImagesLogos ) );

			this._inAction = true;
			this.panelMain.Enabled = false;
			this.pgsLoading.Visible = true;

			this._hilo.Start();
		}

		private void tsmiDelete_Click( object sender, EventArgs e )
		{
			DialogResult result = MetroMessageBox.Show( this, 
				"Se procederá a eliminar todo registro de esta imagen, Deseas continuar?", 
				"Eliminar Imagen", 
				MessageBoxButtons.OKCancel, 
				MessageBoxIcon.Warning, 
				MessageBoxDefaultButton.Button2 
			);

			if ( result == DialogResult.OK )
			{
				string[] relation = ( ( string ) this._ptbSelected.Tag ).Split( '-' );

				int type = Convert.ToInt32( relation[0] );
				int dimension = Convert.ToInt32( relation[1] );

				tLogos logos = this._lLogos.Find( x => x.Dimension == dimension && x.Type == type );

				if ( logos != null )
				{
					this._ptbSelected.Image = null;
					this._ptbSelected.ImageLocation = null;
				}
				else
				{
					this._hilo = new Thread( new ThreadStart( this.DeleteImageLogos ) );

					this.pgsLoading.Visible = true;
					this.panelMain.Enabled = false;
					this._inAction = true;

					this._codigoLogo = logos.Codigo;

					this._hilo.Start();
				}
			}
		}

	}
}
