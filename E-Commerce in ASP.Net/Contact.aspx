 <%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication33._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
        <!-- Bottom Bar End -->
        
        <!-- Breadcrumb Start -->
        <div class="breadcrumb-wrap">
            <div class="container-fluid">
                <ul class="breadcrumb">
                    <li class="breadcrumb-item"><a href="#">Anasayfa</a></li>
                    <li class="breadcrumb-item"><a href="#">Ürünler</a></li>
                    <li class="breadcrumb-item active">İletişim</li>
                </ul>
            </div>
        </div>
        <!-- Breadcrumb End -->
        
        <!-- Contact Start -->
        <div class="contact">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-4">
                        <div class="contact-info">
                            <h2>Ofisimiz</h2>
                            <h3><i class="fa fa-map-marker"></i>Eskişehir,Osmangazi</h3>
                            <h3><i class="fa fa-envelope"></i>market@xxx.com</h3>
                            <h3><i class="fa fa-phone"></i>0500 000 00 00</h3>
                            <div class="social">
                                <a href=""><i class="fab fa-twitter"></i></a>
                                <a href=""><i class="fab fa-facebook-f"></i></a>
                                <a href=""><i class="fab fa-linkedin-in"></i></a>
                                <a href=""><i class="fab fa-instagram"></i></a>
                                <a href=""><i class="fab fa-youtube"></i></a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="contact-info">
                            <h2>Mağazamız</h2>
                            <h3><i class="fa fa-map-marker"></i>Eskişehir,Osmangazi</h3>
                            <h3><i class="fa fa-envelope"></i>market@xxx.com</h3>
                            <h3><i class="fa fa-phone"></i>0500 000 00 00</h3>
                            <div class="social">
                                <a href=""><i class="fab fa-twitter"></i></a>
                                <a href=""><i class="fab fa-facebook-f"></i></a>
                                <a href=""><i class="fab fa-linkedin-in"></i></a>
                                <a href=""><i class="fab fa-instagram"></i></a>
                                <a href=""><i class="fab fa-youtube"></i></a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="contact-form">
                            <form>
                                <div class="row">
                                    <div class="col-md-6">
                                        <input type="text" class="form-control" placeholder="İsminiz " />
                                    </div>
                                    <div class="col-md-6">
                                        <input type="email" class="form-control" placeholder="Mail " />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <input type="text" class="form-control" placeholder="Konu" />
                                </div>
                                <div class="form-group">
                                    <textarea class="form-control" rows="5" placeholder="Mesaj"></textarea>
                                </div>
                                <div><button class="btn" type="submit">Mesaj Gönder</button></div>
                            </form>
                        </div>
                    </div>
                    <div class="col-lg-12">
                        <div class="contact-map">
                            <iframe src="https://www.google.com/maps/d/embed?mid=1mQXg_ZGwvNRQw--WgRXcCL5-K0s" frameborder="0" style="border:0;" allowfullscreen="" aria-hidden="false" tabindex="0"></iframe>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Contact End -->


</asp:Content>
