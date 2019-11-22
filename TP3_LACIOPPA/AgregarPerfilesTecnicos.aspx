<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AgregarPerfilesTecnicos.aspx.cs" Inherits="TP3_LACIOPPA.AgregarPerfilesTecnicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h2>AGREGAR PERFILES</h2>
    <br />
    <p>Nombre de perfil</p>
    <asp:TextBox ID="txtPerfil" runat="server" class="form-control" Width="150px" ></asp:TextBox>
    <br />
    <asp:Button ID="btnperfilTecnico" runat="server" Text="Agregar Perfil"  class="btn btn-primary" OnClick="btnperfilTecnico_Click"  />
    <br />
    <br />
    <table class="table">
        <thead class="thead-dark">
            <tr>
                <th scope="col">PERFILES AGREGADAS</th>
            </tr>
        </thead>
        <tbody>
    
       <% foreach (var item in listarperfiles)
            { %>
            <tr>
              <td><% = item.nombre %></td>
            </tr>
        <% } %>
    
    </tbody>
</table>            
</asp:Content>
