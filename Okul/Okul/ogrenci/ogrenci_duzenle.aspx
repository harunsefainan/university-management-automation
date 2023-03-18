<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ogrenci_duzenle.aspx.cs" Inherits="Okul.ogrenci.ogrenci_duzenle" %>

<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <style>
        .alt {
            position: relative;
            bottom: 0;
            left: 0;
            width: 100%;
            height: 15px;
            /*position: fixed;
            bottom: 0;
            left: 0;
            width: 100%;
            height: 35px;
            width: 100%;
            height: 5%;
            background-color: #ccc;*/
        }
        .center {
            position: absolute;
            right: 300px;
        }
        
    </style>

    <title>ASP.NET MVC Üniversite Yönetim Otomasyonu</title>

    <!-- Bootstrap core CSS -->
    <link href="/css/bootstrap.min.css" rel="stylesheet">
    <link href="/css/styledanger.css" rel="stylesheet" />

    <script src="/js/jquery/jquery.min.js"></script>
    <script src="/js/bootstrap.bundle.min.js"></script>
</head>

<body>

    <!-- Navigation -->
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark static-top">
        <div class="container">
            <a class="navbar-brand" href="#">
                <%--<img src="/img/school.png" width="30" height="30" class="d-inline-block align-top" alt="">--%>
                Üniversite Yönetim</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse center" id="navbarResponsive">
                <ul class="navbar-nav ml-auto">
                    <li class="nav-item px-lg-4 @Html.ActivePage("universite","universite_listesi.aspx")">
                        <a class="nav-link" href="/universite/universite_listesi.aspx">
                            Üniversite İşlemleri
                            <span class="sr-only"></span>
                        </a>
                    </li>
                    <li class="nav-item ">

                        <a class="nav-link  px-lg-4 @Html.ActivePage("fakulte","fakulte_listesi.aspx")" href="/fakulte/fakulte_listesi.aspx">Fakülte İşlemleri</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link px-lg-4 @Html.ActivePage("bolum","bolum_listesi.aspx")" href="/bolum/bolum_listesi.aspx">Bölüm İşlemleri</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link px-lg-4 @Html.ActivePage("ogrenci","ogrenci_listesi.aspx")" href="/ogrenci/ogrenci_listesi.aspx">Öğrenci İşlemleri</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link px-lg-4 @Html.ActivePage("Cıkıs","kullanıcı_giris.aspx")" href="/kullanıcı/kullanıcı_giris.aspx">Çıkış</a>
                    </li>
                </ul>
            </div>  
        </div>
        
    </nav>
    <br />
    <div class="container">
       <form id="form1" runat="server">
           <h3>Öğrenci Düzenle</h3>
           <div class="form-group">
            <label  for="txtOgrenciAdi">Öğrenci Adı</label>
            <asp:TextBox runat="server" ID="txtOgrenciAdi" CssClass="form-control"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtOgrenciAdi" runat="server" ErrorMessage="Öğrenci Adı gerekli"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label  for="txtUniversiteID">Üniversite Adı</label>
            <asp:DropDownList runat="server" CssClass="form-control" ID="universiteCombo" AutoPostBack="true"></asp:DropDownList>  
        </div>
        <div class="form-group">
            <label  for="txtFakulteAdi">Fakülte Adı</label>
            <asp:DropDownList runat="server" CssClass="form-control" ID="fakultecombo" AutoPostBack="true"></asp:DropDownList>  
        </div>
           <div class="form-group">
            <label  for="txtBolumAdi">Bölüm Adı</label>
            <asp:DropDownList runat="server" CssClass="form-control" ID="bolumCombo" AutoPostBack="true"></asp:DropDownList>  
        </div>
           <br />
           <asp:Button Text="Kaydet" ID="btnDuzenle" runat="server"  cssClass="btn btn-success"  OnClick ="btnDuzenle_Click"/>
           <a  class="btn btn-danger" href ="/ogrenci/ogrenci_listesi.aspx">İptal</a>
       </form>
    </div>
   <br />
    <br />


   
    
    
</body>

</html>
