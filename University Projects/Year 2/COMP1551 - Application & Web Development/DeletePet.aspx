<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DeletePet.aspx.cs" Inherits="friendsWithPaws.DeletePet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="space deletePet">
        <asp:Label ID="petLbl" runat="server" Text="Pets"></asp:Label>
       &nbsp;<asp:DropDownList CssClass="textboxspace" ID="petDD" runat="server" Height="25px" Width="136px">
            </asp:DropDownList>
         &nbsp;<asp:Button ID="submit" CssClass="submit"  runat="server" Text="Submit" OnClick="submit_Click" OnClientClick="Confirm()"  />
       </div>
     
            
     <script type = "text/javascript">
        function Confirm() {
            var confirm_value = document.createElement("INPUT");
            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";
            if (confirm("Are You Sure You want to Delete ?")) {
                confirm_value.value = "Yes";
            } else {
                confirm_value.value = "No";
            }
            document.forms[0].appendChild(confirm_value);
        }
    </script>
            
     
            
   
</asp:Content>
