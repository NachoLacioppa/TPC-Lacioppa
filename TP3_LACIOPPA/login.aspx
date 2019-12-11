<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TP3_LACIOPPA.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />  
    <h4>LOGIN</h4>
    <form>
  <div class="form-group">
    <asp:Label Text="USUARIO:" runat="server" />
      <asp:TextBox ID="txtUsuario" runat="server" class="form-control" Width="240px" ></asp:TextBox>
  </div>
  <div class="form-group">
    <asp:Label Text="CONTRASEÑA: " runat="server" />
    <asp:TextBox ID="txtPass" runat="server" class="form-control" Width="240px" TextMode="Password"></asp:TextBox>
     <asp:Label Text="USUARIO/CONTRASEÑA INCORRECTO" runat="server" ID="lblValidado" ForeColor="#FF0909" />
  </div>
        <br />
  <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" class="btn btn-primary" OnClick="btnIngresar_Click"/>
      <br />
</form>
</asp:Content>
