<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<SelectListItem>>" %>
<%
    
 string labelText = string.Empty;
 if (ViewData["label"] != null)
 {
     labelText = ViewData["label"].ToString();
 } %>
 
 <%= Html.Label(labelText) %>
<%= Html.DropDownListFor(m => m, Model, "Please select") %>