import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { RouterModule } from '../../node_modules/@angular/router';
import {PaginatorModule} from 'primeng/paginator';
import { EventsComponent } from './components/events/events.component';
import { VideosComponent } from './components/videos/videos.component';
import { LsComponent } from './components/ls/ls.component';
import { ContactComponent } from './components/contact/contact.component';

@NgModule({
  declarations: [
    AppComponent,
      HomeComponent,
      EventsComponent,
      VideosComponent,
      LsComponent,
      ContactComponent,
         
  ],
  imports: [
    BrowserModule,
      AppRoutingModule,
      RouterModule,
      PaginatorModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
