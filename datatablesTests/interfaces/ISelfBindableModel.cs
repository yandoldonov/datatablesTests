using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace datatablesTests.interfaces
{
    public interface ISelfBindableModel
    {
        void rebuildFromForm(NameValueCollection form);
    }
}