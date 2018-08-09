using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemObjects.SDK;
using RemObjects.DataAbstract;

namespace RPSuiteServer.Classes
{
    public class DataClass
    {
        private IpHttpClientChannel httpChannel;
        private BinMessage Message;
        public IRPDataService servidor;
        private IRPLoginService rpsession;
        public RemObjects.DataAbstract.Server.UserInfo rpUsuario;

        public DataClass()
        {
            httpChannel = new IpHttpClientChannel();
            Message = new BinMessage();

            httpChannel.TargetUrl = System.Configuration.ConfigurationManager.AppSettings["ServerName"];
            rpsession = CoRPLoginService.Create(Message, httpChannel);
            rpUsuario = new RemObjects.DataAbstract.Server.UserInfo();
            //rpsession.Login(usuario, pwd, out rpUsuario);

            //servidor = CoRPDataService.Create(Message, httpChannel);


        }
        public bool LoginAccess(string usuario, string pwd, out RemObjects.DataAbstract.Server.UserInfo infousuario)
        {

            rpsession.Login(usuario, pwd, out rpUsuario);
            infousuario = rpUsuario;
            servidor = CoRPDataService.Create(Message, httpChannel);
            if (rpUsuario == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void LogOut()
        {
            rpsession.Logout();
        }



    }

}