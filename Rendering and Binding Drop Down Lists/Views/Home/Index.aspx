<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Rendering_and_Binding_Drop_Down_Lists.Models.BestPictureViewModel>" %>

<asp:Content ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <% using (Html.BeginForm("Save", "Home"))
       { %>
    <%= Html.EditorFor(m => m.Movies)%><br/>
    <!-- This is an example on how to override the UI Display hint -->
     <%= Html.EditorFor(m => m.TopSongs, new {label = "Top Movies Override"})%>
    <input type="submit" value="Save" />
    <% } %>
</asp:Content>
