﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rendering_and_Binding_Drop_Down_Lists
{
    public class MyModelBinder : DefaultModelBinder
    {
        protected override void SetProperty(ControllerContext controllerContext, ModelBindingContext bindingContext, System.ComponentModel.PropertyDescriptor propertyDescriptor, object value)
        {
            if (propertyDescriptor.PropertyType.IsAssignableFrom(typeof(IEnumerable<SelectListItem>)))
            {
                var valueKey = string.IsNullOrEmpty(bindingContext.ModelName)
                    ? propertyDescriptor.Name
                    : string.Format("{0}.{1}", bindingContext.ModelName, propertyDescriptor.Name);

                bindingContext.ModelState[valueKey].Errors.Clear();

                var listItemValue = bindingContext.ValueProvider.GetValue(valueKey).AttemptedValue;
                var items = propertyDescriptor.GetValue(bindingContext.Model) as IEnumerable<SelectListItem>;
                
                items.Where(i => i.Value == listItemValue).First().Selected = true;

                return;
            }

            base.SetProperty(controllerContext, bindingContext, propertyDescriptor, value);
        }
    }
}
