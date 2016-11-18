using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace BarBlog.Data
{
    public class Factory
    {
        private string _mode;

        public Factory()
        {
            _mode = WebConfigurationManager.AppSettings["Mode"].ToUpper();
        }

        public IPostRepository PostRepository()
        {
            switch (_mode)
            {
                case "MOCK":
                    return new MockPostRepository();
                case "DB":
                    return new DBPostRepository();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
