<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BuscarOrden.aspx.cs" Inherits="TP3_LACIOPPA.BuscarOrden" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form>
    <center>
        <h2>BUSCAR ORDEN ESPECIFICA</h2>
    </center>
    <%--BUSQUEDA ESPESIFICA DE ORDEN--%>
     <div class="form-row">
    <div class="form-group col-md-6">
        <asp:label text="Ingrese Numero de Orden" runat="server" />
        <asp:TextBox ID="txtBuscarOrden" runat="server" class="form-control" Width="150px" TextMode="Number"></asp:TextBox>
        <asp:Label Text="INGRESE EL NUMERO DE ORDEN" ID="lblIngreseNumeroOrden" runat="server" Font-Size="X-Large" ForeColor="#F00006" />
        <br />
        <asp:Button ID="btnBuscarOrden" runat="server" class="btn btn-primary" Text="Buscar Orden" OnClick="btnBuscarOrden_Click" />
        <asp:TextBox ID="txtIDORDEN" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtIDESTADO" runat="server" Visible="false"></asp:TextBox>
    </div>
  </div>

    <%--SI ESTA SIN FINALIZAR MOSTRAR SOLO ESTO--%>
     <div class="form-row">
    <div class="form-group col-md-6">
        <h3>DATOS DEL CLIENTE</h3>
        <asp:Label Text="Nombre: " runat="server" />
        <asp:Label Text=" " runat="server" ID="lblCliNombre"/>
        <br />
        <asp:Label Text="Apellido: " runat="server" />
        <asp:Label Text=" " runat="server" ID="lblCliApellido"/>
        <br />
        <asp:Label Text="Telefono: " runat="server" />
        <asp:Label Text=" " runat="server" ID="lblCliTelefono"/>
        <br />
        <h3>DATOS DEL EQUIPO</h3>
        <asp:Label Text="Numero de serie: " runat="server" />
        <asp:Label Text=" " runat="server" ID="lblEqSN"/>
        <br />
        <asp:Label Text="Marca: " runat="server" />
        <asp:Label Text=" " runat="server" ID="lblEqMarca"/>
        <br />
        <asp:Label Text="Modelo: " runat="server" />
        <asp:Label Text=" " runat="server" ID="lblEqModelo"/>
        <br />
        <h3>PROBLEMA, TECNICO ASIGNADO Y FECHA DE INGRESO</h3>
        <asp:Label Text="Problema: " runat="server" />
        <br />
        <asp:TextBox ID="txtProblema" runat="server" Height="107px" Width="308px" TextMode="MultiLine" Rows=5 Enabled="false"></asp:TextBox>
        <br />
        <asp:Label Text="Tecnico Asignado: " runat="server" />
        <asp:Label Text=" " runat="server" ID="lblTecasignado"/>
        <br />
        <asp:Label Text="Fecha de Ingreso: " runat="server" />
        <asp:Label Text=" " runat="server" ID="lblFechaIng"/>
    </div>
  </div>
    <br />
    <br />
      <%--SI ESTA FINALIZADO MOSTRAR TODO--%>
     <div class="form-row">
    <div class="form-group col-md-6">
        <h3>DATOS DE LA FINALIZACION</h3>
        <asp:Label Text="Informe Final" runat="server" ID="lblinformefinal"/>
        <br />
        <asp:TextBox ID="txtInforme" runat="server" Height="107px" Width="308px" TextMode="MultiLine" Rows=5 Enabled="false"></asp:TextBox>
        <br />
        <asp:Label Text="Repuestos Usados" runat="server" ID="lblRepuestosUsados"/>
        <asp:GridView ID="dwRepuestosUsados" runat="server" OnSelectedIndexChanged="dwRepuestosUsados_SelectedIndexChanged"></asp:GridView>
        <br />
        <asp:Label Text="Fecha de salida: " runat="server" />
        <asp:Label Text=" " runat="server" ID="lblFechaSal"/>
        <br />
        <asp:Label Text="Presupuesto Final: " runat="server" ID="lblpf" ForeColor="Blue" Font-Size="X-Large"/>
        <asp:Label Text=" " runat="server" ID="lblPreciofinal" ForeColor="Blue" Font-Size="X-Large" />
        <asp:Label Text="$" runat="server" ForeColor="Blue" Font-Size="X-Large"/>
    </div>
  </div>
</form>
</asp:Content>
