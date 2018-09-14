<%@ Page Title="" Language="C#" MasterPageFile="~/PruebaDesarrollo.Master" AutoEventWireup="true" CodeBehind="TablaProducto.aspx.cs" Inherits="PruebaDesarrolloW.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div><h1>Bienvenido a la tienda</h1></div>
              <input type="radio" name="radios" id="radioNombre" value=1>Nombre<br/>
              <input type="radio" name="radios" id="radioPrecio" value=2>Precio<br/>
              <input type="radio" name="radios" id="radioExistencia" value=3>Existencia <br/>
                <input type="button" value="Ascendente" id ="btnAscendente"/>
                <input type="button" value="Descendente" id ="btnDescencente"/>
        <table id ="TablaProductos">
        <thead>
            <tr>
                <th>Nombre</th>
                <th>Precio</th>
                <th>Descripcion</th>
                <th>Existencias</th>
                <th>Categoria</th>
            </tr>
        </thead>
        <tbody id="ResultadoProductos">
            <tr>
                <td>Nito</td>
                <td>10</td>
                <td>Pan con relleno de chocolate</td>
                <td>36</td>
                <td>Pan</td>
            </tr>
        </tbody>
    </table>
</asp:Content>
