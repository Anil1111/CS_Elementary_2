using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookDatabase;
using PhoneBookView;
using System.Windows.Forms;
using System.Data;


namespace PhoneBookPresenter
{
    public class MainPresenter
    {
        private Wrapper wrapper;
        private PhoneBookView.IUserDialog view;


        public MainPresenter(string username, string password)
        {
            wrapper = new Wrapper(username, password);

        }


        public void selectAll()
        {
            DBDelegate del1 = new DBDelegate(wrapper.SelectAll);
            del1.Invoke();
        }

        public Tuple<string, bool, bool> ButtonConnection()
        {
            var result = wrapper.buttonPushForConnection();
            return result;
        }

        public DataTable SelectAll()
        {

            var ds = wrapper.SelectAll();
            return ds;
        }

        public string ReturnUserName()
        {
            return wrapper.ReturnUserName();
        }

        public string ReturnDatabases()
        {
            return wrapper.ReturnDBName();
        }

        public DataTable UpdateCell(int numb, DataGridViewRow row)
        {
            return wrapper.UpdateCellName(numb, row);

        }

        public void InputRow(HelpProj.InsertDialogData data)
        {
            wrapper.AddRow(data);
        }
    }
}
