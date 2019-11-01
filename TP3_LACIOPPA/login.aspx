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
       
</form>
</asp:Content>
