using datatablesTests.interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace datatablesTests.modelBinders
{
    public class selfBuindableViewModelBinder<TModel> : IModelBinder where TModel : ISelfBindableModel
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            ISelfBindableModel model = (TModel)Activator.CreateInstance(typeof(TModel));
            model.rebuildFromForm(controllerContext.HttpContext.Request.Form);

            return model;
        }
    }
}