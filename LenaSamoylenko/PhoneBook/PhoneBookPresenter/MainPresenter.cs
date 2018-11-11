using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookDatabase;

namespace PhoneBookPresenter
{
    public class MainPresenter
    {


        public MainPresenter()
        {


        }
        public void selectAll()
        {
            DBDelegate del1 = new DBDelegate((new Wrapper()).SelectAll);
            del1.Invoke();
        }

    }
}
