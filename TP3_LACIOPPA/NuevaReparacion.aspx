<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NuevaReparacion.aspx.cs" Inherits="TP3_LACIOPPA.NuevaReparacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
             <h2>NUEVA REPARACION</h2>
    </center>

    <asp:Label Text=" " runat="server" ID="lblperfiltec" Visible="false"/>
<form>
        <div class="container">

            <div class="form-row">
                    <h4>
                        <asp:Label Text="Numero de Orden: " runat="server" CssClass="col-form-label"/>
        	            <asp:Label Text=" " runat="server" ID="lblNumeroOrden" Font-Bold="True" CssClass="col-form-label"/>
                    </h4>
            </div>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <asp:Label Text="Buscar Cliente (solo por dni)" runat="server" CssClass="col-form-label"/>
         <asp:TextBox ID="txtCliente" runat="server" class="form-control" placeholder="DNI" Width="150px" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Button ID="btnBuscarCliente" runat="server" Text="Buscar Cliente" class="btn btn-primary" OnClick="btnBuscarCliente_Click" />
        <br />
        <br />
        <asp:TextBox ID="txtidcliente" runat="server" class="form-control" placeholder="ID" Width="150px" Enabled="False" Visible="false" CssClass="form-control"></asp:TextBox>
        <asp:TextBox ID="txtNombre" runat="server" class="form-control" placeholder="Nombre" Width="150px" Enabled="False" CssClass="form-control"></asp:TextBox>
        <asp:TextBox ID="txtApellido" runat="server" class="form-control" placeholder="Apellido" Width="150px" Enabled="False" CssClass="form-control"></asp:TextBox>
        <asp:TextBox ID="txtTelefono" runat="server" class="form-control" placeholder="Telefono" Width="150px" Enabled="False" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-6">
                    <asp:Label Text="BUSQUEDA DE EQUIPO" runat="server" CssClass="col-form-label"/>
    <asp:TextBox ID="txtidequipo" runat="server" class="form-control" placeholder="ID" Width="150px" Height="23px" Enabled="False" Visible="false"></asp:TextBox>
    <asp:TextBox ID="txtNumeroSerie" runat="server" class="form-control" placeholder="Numero de Serie" Width="250px" CssClass="form-control"></asp:TextBox>
                    <asp:Button ID="btnHabilitaSN" runat="server" Text="Cambiar Numero de serie" class="btn btn-warning" OnClick="btnHabilitaSN_Click"/>
        <br />
    <asp:Label Text="EL EQUIPO NO EXISTTE, POR FAVOR CARGUE LA MARCA Y EL MODELO" runat="server" ID="lblEquipo" CssClass="col-form-label"/>
     <br />
    <asp:Button ID="btnBuscarEquipo" runat="server" Text="Buscar Equipo" class="btn btn-primary" OnClick="btnBuscarEquipo_Click" />
    <br />
                    <br />
    <asp:TextBox ID="txtMarca" runat="server" class="form-control" placeholder="Marca" Width="250px" CssClass="form-control"></asp:TextBox>
        <br />
    <asp:TextBox ID="txtModelo" runat="server" class="form-control" placeholder="Modelo" Width="250px" CssClass="form-control"></asp:TextBox>
                 </div>
            </div>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <asp:Label Text="Problema" runat="server" CssClass="col-form-label"/>
        <br />
        <asp:TextBox ID="txtProblema" runat="server" Height="107px" Width="308px" TextMode="MultiLine" Rows=5></asp:TextBox>
        <br />
        <br />
        <asp:Label Text="Tecnico Asignado" runat="server" CssClass="col-form-label"/>
        <asp:Label Text=" " runat="server" ID="lblusuarioTec" CssClass="col-form-label"/>
        <br />
        <br />
        <asp:DropDownList ID="dwTecnico" runat="server" class="btn btn-secondary btn-sm dropdown-toggle"></asp:DropDownList>
        <asp:Label Text=" " runat="server" ID="lblIDTec" Visible="false" CssClass="col-form-label"/>
        <br />
        <br />
        <asp:Button ID="btnCargarReparacion" runat="server" Text="Carga Reparacion" class="btn btn-primary" OnClick="btnCargarReparacion_Click" />
                </div>
            </div>

        </div>
</form>
</asp:Content>
