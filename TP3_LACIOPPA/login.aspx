<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TP3_LACIOPPA.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />  
    <h4>LOGIN</h4>
    <form>
  <div class="form-group">
    <label for="exampleInputEmail1">Usuario:</label>
      <asp:TextBox ID="txtUsuario" runat="server" class="form-control" Width="150px" ></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Password:</label>
    <asp:TextBox ID="txtPass" runat="server" class="form-control" Width="150px" ></asp:TextBox>
  </div>
  <asp:Button ID="btnIngresar" runat="server" Text="Ingresar"  class="btn btn-primary" OnClick="btnIngresar_Click" />
        <div class="btn-group" role="group">
    <button id="btnGroupDrop1" type="button" class="btn btn-secondary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
      Dropdown
    </button>
    <div class="dropdown-menu" aria-labelledby="btnGroupDrop1">
      <a class="dropdown-item" href="#">Dropdown link</a>
      <a class="dropdown-item" href="#">Dropdown link</a>
    </div>
  </div>
</div>
</form>
</asp:Content>
