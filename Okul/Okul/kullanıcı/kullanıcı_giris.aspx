<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kullanıcı_giris.aspx.cs" Inherits="Okul.kullanıcı.kullanıcı_giris" %>

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
            <h2>Üniversite Yönetim<br>Giriş Sayfası</h2>
            <p>Erişmek için buradan giriş yapın veya kayıt olun.</p>
         </div>
      </div>
      <div class="main">
         <div class="col-md-6 col-sm-12">
            <div class="login-form">
               <form>
                   <div class="form-group">
                        <label for="txtKadi">Kullanıcı Adı</label>
                        <asp:TextBox runat="server" type="text" ID="txtKadi" CssClass="form-control" placeholder="Kullanıcı Adı"/>    
                       <br />  
                       <label for="txtSifre">Parola</label>
                        <asp:TextBox runat="server" ID="txtSifre" CssClass="form-control" type="password" placeholder="Parola"/>
                   </div>
                   <br />
                  <asp:Button Text="Giriş Yap" ID="btnGiris" runat="server"  cssClass="btn btn-secondary"  OnClick ="btnGiris_Click"/>
                   <asp:Button Text="Kayıt Ol" ID="btnKayıt" runat="server"  cssClass="btn btn-secondary"  OnClick ="btnKayıt_Click"/>
                   <br />
               </form>
            </div>
         </div>
      </div>
    </form>    
</body>
</html>

