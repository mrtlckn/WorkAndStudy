 <%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication33._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 
        
        <!-- Breadcrumb Start -->
        <div class="breadcrumb-wrap">
            <div class="container-fluid">
                <ul class="breadcrumb">
                    <li class="breadcrumb-item"><a href="#">Anasayfa</a></li>
                    <li class="breadcrumb-item"><a href="#">Ürünler</a></li>
                    <li class="breadcrumb-item active">Hesaplar</li>
                </ul>
            </div>
        </div>
        <!-- Breadcrumb End -->
        
        <!-- My Account Start -->
        <div class="my-account">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-md-3">
                        <div class="nav flex-column nav-pills" role="tablist" aria-orientation="vertical">
                            <a class="nav-link active" id="dashboard-nav" data-toggle="pill" href="#dashboard-tab" role="tab"><i class="fa fa-tachometer-alt"></i>Panel</a>
                            <a class="nav-link" id="orders-nav" data-toggle="pill" href="#orders-tab" role="tab"><i class="fa fa-shopping-bag"></i>Şiparişler</a>
                            <a class="nav-link" id="payment-nav" data-toggle="pill" href="#payment-tab" role="tab"><i class="fa fa-credit-card"></i>Ödeme Methodu</a>
                            <a class="nav-link" id="address-nav" data-toggle="pill" href="#address-tab" role="tab"><i class="fa fa-map-marker-alt"></i>Adres</a>
                            <a class="nav-link" id="account-nav" data-toggle="pill" href="#account-tab" role="tab"><i class="fa fa-user"></i>Hesap Detayları</a>
                            <a class="nav-link" href="Login"><i class="fa fa-sign-out-alt"></i>Çıkış Yap</a>
                        </div>
                    </div>
                    <div class="col-md-9">
                        <div class="tab-content">
                            <div class="tab-pane fade show active" id="dashboard-tab" role="tabpanel" aria-labelledby="dashboard-nav">
                                <h4>Panel</h4>
                                <p>
                                    Biglilerinize bakabilirsiniz.
                                </p> 
                            </div>
                            <div class="tab-pane fade" id="orders-tab" role="tabpanel" aria-labelledby="orders-nav">
                                <div class="table-responsive">
                                    <table class="table table-bordered">
                                        <thead class="thead-dark">
                                            <tr>
                                                <th>No</th>
                                                <th>Ürün</th>
                                                <th>Tarih</th>
                                                <th>Fiyat</th>
                                                <th>Durum</th>
                                                <th>Faaliyet</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>1</td>
                                                <td>Ürün İsmi</td>
                                                <td>01 06 2021</td>
                                                <td>$99</td>
                                                <td>Onaylandı</td>
                                                <td><button class="btn">Göster</button></td>
                                            </tr>
                                            <tr>
                                                <td>2</td>
                                                <td>Ürün İsmi</td>
                                                <td>01 06 2021</td>
                                                <td>$99</td>
                                                <td>Onaylandı</td>
                                                <td><button class="btn">Göster</button></td>
                                            </tr>
                                            <tr>
                                                <td>3</td>
                                                <td>Ürün İsmi</td>
                                                <td>01 06 2021</td>
                                                <td>$99</td>
                                                <td>Onaylandı</td>
                                                <td><button class="btn">Göster</button></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            <div class="tab-pane fade" id="payment-tab" role="tabpanel" aria-labelledby="payment-nav">
                                <h4>Ödeme Methodu</h4>
                                <p>
                                    Ödeme methodlarını seçebilirsiniz.
                                </p> 
                            </div>
                            <div class="tab-pane fade" id="address-tab" role="tabpanel" aria-labelledby="address-nav">
                                <h4>Adres</h4>
                                <div class="row">
                                    <div class="col-md-6">
                                        <h5>Fatura Adresi</h5>
                                        <p>Davet Sokak, Eskişehir, TR</p>
                                        <p>Mobile: 0500-000-00-00</p>
                                        <button class="btn">Adresi Düzenle</button>
                                    </div>
                                    <div class="col-md-6">
                                        <h5>Ürün Adresi</h5>
                                        <p>Davet Sokak, Eskişehir, TR</p>
                                        <p>Mobile: 0500-000-00-00</p>
                                        <button class="btn">Adresi Düzenle</button>
                                    </div>
                                </div>
                            </div>
                            <div class="tab-pane fade" id="account-tab" role="tabpanel" aria-labelledby="account-nav">
                                <h4>Hesap Detayları</h4>
                                <div class="row">
                                    <div class="col-md-6">
                                        <input class="form-control" type="text" placeholder="İsim">
                                    </div>
                                    <div class="col-md-6">
                                        <input class="form-control" type="text" placeholder="Soyisim">
                                    </div>
                                    <div class="col-md-6">
                                        <input class="form-control" type="text" placeholder="Mobile">
                                    </div>
                                    <div class="col-md-6">
                                        <input class="form-control" type="text" placeholder="Email">
                                    </div>
                                    <div class="col-md-12">
                                        <input class="form-control" type="text" placeholder="Adres">
                                    </div>
                                    <div class="col-md-12">
                                        <button class="btn">Hesabı Güncelle</button>
                                        <br><br>
                                    </div>
                                </div>
                                <h4>Şifre Değiştirme</h4>
                                <div class="row">
                                    <div class="col-md-12">
                                        <input class="form-control" type="password" placeholder="Geçerli Şifre">
                                    </div>
                                    <div class="col-md-6">
                                        <input class="form-control" type="text" placeholder="Yeni Şifre">
                                    </div>
                                    <div class="col-md-6">
                                        <input class="form-control" type="text" placeholder="Yeni Şifreyi Giriniz">
                                    </div>
                                    <div class="col-md-12">
                                        <button class="btn">Kaydet</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- My Account End -->
</asp:Content>
