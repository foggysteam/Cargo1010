<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container1" id="main">
        <div id="topDiv" class="col-md-12">
            <div class="row">
                <div class="col-md-9">
                    <h2>10/10 Cargo</h2>
                    <h2>Calculate Your Costs And Durations</h2>
                </div>
                <div class="col-md-3">
                    <img src="/img/icon.png" />
                </div>
            </div>


            <div class="row">
                <div class="col-md-4">
                    <asp:Label ID="Label2" runat="server" Text="From:"></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:DropDownList ID="DropDownList1st" runat="server" CssClass="form-control" OnSelectedIndexChanged="DropDownList1st_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>London</asp:ListItem>
                        <asp:ListItem>Paris</asp:ListItem>
                        <asp:ListItem>Frankfurt</asp:ListItem>
                        <asp:ListItem>Dubai</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                        <asp:ListItem>Sydney</asp:ListItem>
                        <asp:ListItem>New York</asp:ListItem>
                        <asp:ListItem>Los Angeles</asp:ListItem>
                        <asp:ListItem>Toronto</asp:ListItem>
                        <asp:ListItem>Amsterdam</asp:ListItem>
                    </asp:DropDownList>
                </div>

            </div>
            <br />

            <div class="row">
                <div class="col-md-4">
                    <asp:Label ID="Label3" runat="server" Text="To:"></asp:Label>
                </div>

                <div class="col-md-5">
                    <asp:DropDownList ID="DropDownList2nd" runat="server" OnSelectedIndexChanged="DropDownList2nd_SelectedIndexChanged" CssClass="form-control" AutoPostBack="True">
                        <asp:ListItem>London</asp:ListItem>
                        <asp:ListItem>Paris</asp:ListItem>
                        <asp:ListItem>Frankfurt</asp:ListItem>
                        <asp:ListItem>Dubai</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                        <asp:ListItem>Sydney</asp:ListItem>
                        <asp:ListItem>New York</asp:ListItem>
                        <asp:ListItem>Los Angeles</asp:ListItem>
                        <asp:ListItem>Toronto</asp:ListItem>
                        <asp:ListItem>Amsterdam</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <br />
            <div class="row">
                <div class="col-md-4">
                    <asp:Label ID="Label4" runat="server" Text="Transport Method:"></asp:Label>
                </div>

                <div class="col-md-5">
                    <asp:DropDownList ID="DropDownListAirLand" runat="server" CssClass="form-control" OnSelectedIndexChanged="DropDownListAirLand_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>Select:</asp:ListItem>
                        <asp:ListItem>Land-Sea</asp:ListItem>
                        <asp:ListItem>Air</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <br />

            <div class="row">
                <div class="col-md-4">
                    <asp:Label ID="LabelWeight" runat="server" Text="Parcel Weight in kg:"></asp:Label>
                </div>

                <div class="col-md-5">
                    <asp:TextBox ID="TextBoxWeight" runat="server" CssClass="form-control" Text="0"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    <asp:Label ID="LabelHeight" runat="server" Text="Parcel Height in cm:"></asp:Label>
                </div>

                <div class="col-md-5">
                    <asp:TextBox ID="TextBoxHeight" runat="server" CssClass="form-control" Text="0"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    <asp:Label ID="LabelWidth" runat="server" Text="Parcel Width in cm:"></asp:Label>
                </div>

                <div class="col-md-5">
                    <asp:TextBox ID="TextBoxWidth" runat="server" CssClass="form-control" Text="0"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    <asp:Label ID="LabelLength" runat="server" Text="Parcel Length in cm:"></asp:Label>
                </div>

                <div class="col-md-5">
                    <asp:TextBox ID="TextBoxLength" runat="server" CssClass="form-control" Text="0"></asp:TextBox>
                </div>
            </div>
            

        </div>

        <hr />
        <div id="botDiv" class="col-md-12">
            <div class="row">
                <div class="col-md-4">
                    <asp:Button ID="Button1" runat="server" Text="Get Cost" CssClass="btn btn-default" OnClick="Button1_Click" />
                </div>

                <div class="col-md-8">
                    <asp:Label ID="LabelCost" runat="server" Text="" ></asp:Label>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    <asp:Button ID="Button2" runat="server" Text="Get Duration" CssClass="btn btn-default" OnClick="Button2_Click" />
                </div>

                <div class="col-md-8">
                    <asp:Label ID="LabelDuration" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
