<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BuscarOrden.aspx.cs" Inherits="TP3_LACIOPPA.BuscarOrden" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form>

    <center>
        <h2>BUSCAR ORDEN ESPECIFICA</h2>
    </center>
    <div class="container">
         <%--BUSQUEDA ESPESIFICA DE ORDEN--%>
    <div class="form-group">
        <asp:label text="Ingrese Numero de Orden" runat="server" CssClass="col-form-label"/>
        <asp:TextBox ID="txtBuscarOrden" runat="server" class="form-control" Width="150px" TextMode="Number"></asp:TextBox>
        <asp:Label Text="INGRESE EL NUMERO DE ORDEN" ID="lblIngreseNumeroOrden" runat="server" Font-Size="X-Large" ForeColor="#F00006" CssClass="col-form-label"/>
        <br />
        <asp:Button ID="btnBuscarOrden" runat="server" class="btn btn-primary" Text="Buscar Orden" OnClick="btnBuscarOrden_Click" />
        <asp:TextBox ID="txtIDORDEN" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtIDESTADO" runat="server" Visible="false"></asp:TextBox>
    </div>

    <%--SI ESTA SIN FINALIZAR MOSTRAR SOLO ESTO--%>
        <asp:Label Text="DATOS DE LA ENTRADA" runat="server" CssClass="col-form-label" Font-Size="X-Large" ForeColor="#000099"/>
        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label Text="DATOS DEL CLIENTE" runat="server" Font-Size="Large" ForeColor="#0066FF" CssClass="col-form-label"/>
        <br />
        <asp:Label Text="Nombre: " runat="server" CssClass="col-form-label"/>
        <asp:Label Text=" " runat="server" ID="lblCliNombre" CssClass="col-form-label"/>
        <br />
        <asp:Label Text="Apellido: " runat="server" CssClass="col-form-label"/>
        <asp:Label Text=" " runat="server" ID="lblCliApellido" CssClass="col-form-label"/>
        <br />
        <asp:Label Text="Telefono: " runat="server" CssClass="col-form-label"/>
        <asp:Label Text=" " runat="server" ID="lblCliTelefono" CssClass="col-form-label"/>
        </div>

            <div class="form-group col-md-6">
        <asp:Label Text="DATOS DEL EQUIPO" runat="server" Font-Size="Large" ForeColor="#0066FF" CssClass="col-form-label"/>
             <br />
        <asp:Label Text="Numero de serie: " runat="server" CssClass="col-form-label"/>
        <asp:Label Text=" " runat="server" ID="lblEqSN" CssClass="col-form-label"/>
        <br />
        <asp:Label Text="Marca: " runat="server" CssClass="col-form-label"/>
        <asp:Label Text=" " runat="server" ID="lblEqMarca" CssClass="col-form-label"/>
        <br />
        <asp:Label Text="Modelo: " runat="server" CssClass="col-form-label"/>
        <asp:Label Text=" " runat="server" ID="lblEqModelo" CssClass="col-form-label"/>
        </div>
            </div>
            
        

         

         <div class="form-row">
             <div class="form-group col-md-6">
                 <asp:Label Text="FECHA DE INGRESO, PROBLEMA, TECNICO" runat="server" Font-Size="Large" ForeColor="#0066FF" CssClass="col-form-label"/>
             <br />
        <asp:Label Text="Problema: " runat="server" />
        <br />
        <asp:TextBox ID="txtProblema" runat="server" Height="107px" Width="308px" TextMode="MultiLine" Rows=5 Enabled="false" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label Text="Tecnico Asignado: " runat="server" CssClass="col-form-label"/>
        <asp:Label Text=" " runat="server" ID="lblTecasignado" CssClass="col-form-label"/>
        <br />
        <asp:Label Text="Fecha de Ingreso: " runat="server" CssClass="col-form-label"/>
        <asp:Label Text=" " runat="server" ID="lblFechaIng" CssClass="col-form-label"/>
        </div>
     </div>
         
      <%--SI ESTA FINALIZADO MOSTRAR TODO--%>
     <div class="form-row">
    <div class="form-group col-md-6">
        <asp:Label Text="DATOS DE LA SALIDA" runat="server" CssClass="col-form-label" Font-Size="X-Large" ForeColor="#000099"/>
        <br />
        <asp:Label Text="Informe Final" runat="server" ID="lblinformefinal" CssClass="col-form-label"/>
        <br />
        <asp:TextBox ID="txtInforme" runat="server" Height="107px" Width="308px" TextMode="MultiLine" Rows=5 Enabled="false" CssClass="form-control"></asp:TextBox>
        <br />
        </div>
         <div class="form-group col-md-6">
             <br />
             <br />
            <asp:Label Text="Repuestos Usados" runat="server" ID="lblRepuestosUsados" CssClass="col-form-label"/>
        <asp:GridView ID="dwRepuestosUsados" runat="server" OnSelectedIndexChanged="dwRepuestosUsados_SelectedIndexChanged" AutoGenerateColumns="false" ShowFooter="false" CssClass="table-bordered">
            <Columns>
                <asp:TemplateField HeaderText="Codigo">
                <ItemTemplate> 
                        <asp:label text='<%# Eval("Codigo")%>' runat="server" />
                    </ItemTemplate>
                    </asp:TemplateField>
            </Columns>
                        <Columns>
                <asp:TemplateField HeaderText="Nombre">
                <ItemTemplate> 
                        <asp:label text='<%# Eval("Nombre")%>' runat="server" />
                    </ItemTemplate>
                    </asp:TemplateField>
            </Columns>
                                 <Columns>
                <asp:TemplateField HeaderText="Precio">
                <ItemTemplate> 
                        <asp:label text='<%# Eval("precio")%>' runat="server" />
                    </ItemTemplate>
                    </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label Text="Fecha de salida: " runat="server" />
        <asp:Label Text=" " runat="server" ID="lblFechaSal"/>
        <br />
        <asp:Label Text="Presupuesto Final: " runat="server" ID="lblpf" ForeColor="Blue" Font-Size="X-Large" CssClass="col-form-label"/>
        <asp:Label Text=" " runat="server" ID="lblPreciofinal" ForeColor="Blue" Font-Size="X-Large" CssClass="col-form-label"/>
        <asp:Label Text="$" runat="server" ForeColor="Blue" Font-Size="X-Large" CssClass="col-form-label"/>
        </div>
    </div>
  </div>
</form>
</asp:Content>