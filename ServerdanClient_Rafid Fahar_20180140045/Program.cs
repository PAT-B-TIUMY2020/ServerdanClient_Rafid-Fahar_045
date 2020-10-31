using ServiceMtk_P2_045;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerdanClient_Rafid_Fahar_20180140045
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        
    }
    public class Server
    {
        public void OnServer()
        {
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(Matematika));
                hostObj.Open();
                Console.WriteLine("Server is Ready!!!");
                Console.ReadLine();
                hostObj.Close();
            }
            catch (Exception ex)
            {
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
        public void OffServer()
        {
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(Matematika));
                hostObj.Open();
                Console.WriteLine("Server is Off!!!");
                Console.ReadLine();
                hostObj.Close();
            }
            catch (Exception ex)
            {
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

    }
}
