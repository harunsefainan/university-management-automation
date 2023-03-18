<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kullanıcı_ekle.aspx.cs" Inherits="Okul.kullanıcı.kullanıcı_ekle" %>

<!DOCTYPE html>

<html lang"en">
<head>  
    <title>Üniversite Yönetim Giriş Sayfası</title>
    <link href="/css/bootstrap.min.css" rel="stylesheet">
    <script src="/js/bootstrap.min.js"></script>
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <link href="../css/StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="sidenav">
         <div class="login-main-text">
            <h2>Üniversite Yönetim<br>Kayıt Sayfası</h2>
         </div>
      </div>
      <div class="main">
         <div class="col-md-6 col-sm-12">
            <div class="login-form">
               <form>
                   <div class="form-group">
                        <label for="txtKadi">Kullanıcı Adı</label>
                        <asp:TextBox runat="server" type="text" ID="txtKadi" CssClass="form-control" placeholder="Kullanıcı Adı"/>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtKadi" runat="server" ErrorMessage="Kullanıcı Adı gerekli"></asp:RequiredFieldValidator>
                  </div>
                   <div class="form-group">
                        <label for="txtAdi">Ad</label>
                        <asp:TextBox runat="server" ID="txtAdi" CssClass="form-control"  placeholder="Ad"/>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtAdi" runat="server" ErrorMessage="Ad gerekli"></asp:RequiredFieldValidator>
                  </div>
                   <div class="form-group">
                        <label for="txtSoyadi">Soyad</label>
                        <asp:TextBox runat="server" type="text" ID="txtSoyadi" CssClass="form-control" placeholder="Soyad"/>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtSoyadi" runat="server" ErrorMessage="Soyad gerekli"></asp:RequiredFieldValidator>
                  </div>
                   <div class="form-group">
                        <label for="txtEposta">Eposta</label>
                        <asp:TextBox runat="server" ID="txtEposta" CssClass="form-control"  placeholder="Eposta"/>
                        <asp:RequiredFieldValidator ID="Validator4" ControlToValidate="txtEposta" runat="server" ErrorMessage="Eposta gerekli"></asp:RequiredFieldValidator>
                   <div class="form-group">
                        <label for="txtSifre">Parola</label>
                        <asp:TextBox runat="server" ID="txtSifre" CssClass="form-control" type="password"  placeholder="Parola"/>   
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtSifre" runat="server"   ErrorMessage ="Parola gerekli"></asp:RequiredFieldValidator>
                    </div>                             
                   <asp:Button Text="Kaydet" ID="btnKaydet" runat="server"  cssClass="btn btn-secondary"  OnClick ="btnKayıt_Click"/>                                     
               </form>
            </div>
         </div>
      </div>
    </form>   
</body>
</html>

