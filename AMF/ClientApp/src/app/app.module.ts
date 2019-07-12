import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { RouterModule } from '../../node_modules/@angular/router';
import { PaginatorModule } from 'primeng/paginator';
import { EventsComponent } from './components/events/events.component';
import { VideosComponent } from './components/videos/videos.component';
import { ContactComponent } from './components/contact/contact.component';
import { MailingListService } from './services/MailingListService';
import { HttpClientModule } from '@angular/common/http';
import { ShopComponent } from './components/shop/shop.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    EventsComponent,
    VideosComponent,
    ContactComponent,
    ShopComponent



  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule,
    PaginatorModule,
    HttpClientModule
  ],
  providers: [MailingListService],
  bootstrap: [AppComponent]
})
export class AppModule { }
