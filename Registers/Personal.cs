using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Options;
using Objects.Processes;

namespace Registers
{
    public class Personal : Connection
    {
        private string _msgExceptionRegPersonal,
                       _Controller = "api/registeralumno";

        private OpSRegisterPersonal _DataPersonal = new OpSRegisterPersonal();

        #region Propiedades
        public string MsERegistrarPersonal
        {
            get { return this._msgExceptionRegPersonal; }
        }
        public OpSRegisterPersonal DataPersonal
        {
            get { return this._DataPersonal; }
            set
            {
                this._DataPersonal = value;
            }
        }

        #endregion

        #region Metodos
        public bool SendDataPersonal()
        {
            Query query = new Query(this._Controller);
            query.RequestParameters = this._DataPersonal;

            try
            {
                query.SendRequestPOST();
                return true;
            }
            catch (Exception e)
            {
                this._msgExceptionRegPersonal = e.Message;
                return false;
            }
        }

        #endregion
    }
}
