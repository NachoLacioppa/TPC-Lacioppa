<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TP3_LACIOPPA.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form>
<div class="card text-center">
  <div class="card-header">
    Bienvenido a IL TALLER
  </div>
  <div class="card-body">
    <h5 class="card-title">INGRESE SUS CREDENCIALES</h5>
    <asp:Label Text="USUARIO:" runat="server" />
    <center>
     <asp:TextBox ID="txtUsuario" runat="server" class="form-control" Width="250px"></asp:TextBox>
    </center>
    <br />
    <asp:Label Text="CONTRASEÑA: " runat="server" />
      <center>
            
          <asp:TextBox ID="txtPass" runat="server" class="form-control" TextMode="Password" Width="250px"></asp:TextBox>
      </center>
    <br />
    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" class="btn btn-primary" OnClick="btnIngresar_Click"/>
  </div>
  <div class="card-footer text-muted">
    <asp:Label Text="USUARIO/CONTRASEÑA INCORRECTO" runat="server" ID="lblValidado" ForeColor="#FF0909" />
  </div>
</div>
</form>
</asp:Content>
