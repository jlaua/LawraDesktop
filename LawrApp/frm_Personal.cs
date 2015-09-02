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
using Access;

namespace LawrApp
{
	public partial class frm_Personal : MetroForm
	{
		private DataGeneral _data;
		private ConfigServer _cf = new ConfigServer();

		public frm_Personal( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
			this.lblFullName.Text = this._cf.getAppSettings( "UserName" );
			this.lblCargo.Text = this._cf.getAppSettings( "UserType" );
			this.ptbImagePorfile.ImageLocation = this._cf.getAppSettings( "UserPictureUrl" );

			this.lblNameInstitucion.Text = this._cf.getAppSettings( "InstitutionName" ).ToUpper();
			this.lblAddressInstitucion.Text = this._cf.getAppSettings( "BranchAddress" );
			this.ptbLogoInstitucion.ImageLocation = this._cf.getAppSettings( "InstitutionLogo" );
		}

		void LoadMessages()
		{
			for ( int i = 0; i <= 10; i++ )
			{
				Panel pn = new Panel();
				MetroLink mlk = new MetroLink();
				MetroLabel mlblDate = new MetroLabel();
				MetroLabel mlblDesc = new MetroLabel();
				// 
				// panel Interno
				// 
				pn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				pn.Controls.Add( mlblDesc );
				pn.Controls.Add( mlblDate );
				pn.Controls.Add( mlk );
				this.flpanel_Mensajes.SetFlowBreak( pn, true );
				pn.Location = new System.Drawing.Point( 3, 3 );
				pn.Name = "panel_" + ( ( i < 10 ) ? "0" : "" ) + i;
				pn.Size = new System.Drawing.Size( 223, 95 );
				pn.TabIndex = i + 1;
				// 
				// Descripción
				// 
				mlblDesc.FontSize = MetroFramework.MetroLabelSize.Small;
				mlblDesc.Location = new System.Drawing.Point( 3, 40 );
				mlblDesc.Name = "metroLabel_" + ( ( i < 10 ) ? "0" : "" ) + i;
				mlblDesc.Size = new System.Drawing.Size( 215, 45 );
				mlblDesc.TabIndex = 1;
				mlblDesc.Text = "Lorem Ipsum dolor sit amet siempre y cuando estemos todos unidos";
				mlblDesc.WrapToLine = true;
				// 
				// Nombre de la Persona
				// 
				mlk.Location = new System.Drawing.Point( 3, 6 );
				mlk.Name = "metroLink_" + ( ( i < 10 ) ? "0" : "" ) + i;
				mlk.Size = new System.Drawing.Size( 215, 14 );
				mlk.TabIndex = 0;
				mlk.Text = "José Alejandro Vilchez M._" + i;
				mlk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				mlk.UseSelectable = true;
				mlk.Click += LinkDinamic_Click;
				// 
				// Fecha de enviado
				// 
				mlblDate.FontSize = MetroFramework.MetroLabelSize.Small;
				mlblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
				mlblDate.Location = new System.Drawing.Point( 3, 23 );
				mlblDate.Name = "metroLabel_" + ( ( i < 10 ) ? "0" : "" ) + i;
				mlblDate.Size = new System.Drawing.Size( 215, 15 );
				mlblDate.TabIndex = i;
				mlblDate.Text = DateTime.Now.ToString();

				this.flpanel_Mensajes.Controls.Add( pn );
			}
		}

		void LinkDinamic_Click( object sender, EventArgs e )
		{
			MetroLink met = ( MetroLink ) sender;
			Panel pn = ( Panel ) met.Parent;

			DialogResult res = MessageBox.Show( this, "Borrarlo", "Pregunta?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question );

			if ( res == DialogResult.OK )
			{
				FlowLayoutPanel fpn = ( FlowLayoutPanel ) pn.Parent;
				fpn.Controls.Remove( pn );
			}
		}

		private void frm_Personal_Load( object sender, EventArgs e )
		{
			this.LoadMessages();
		}
	}
}
