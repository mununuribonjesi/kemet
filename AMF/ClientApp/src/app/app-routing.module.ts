import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { EventsComponent } from './components/events/events.component';
import { VideosComponent } from './components/videos/videos.component';
import { ContactComponent } from './components/contact/contact.component';
import { ShopComponent } from './components/shop/shop.component';

const routes: Routes = [
    { path:'', redirectTo:'/home',pathMatch:'full'},
    { path:'home',component: HomeComponent},
    { path:'events',component: EventsComponent},
  { path: 'videos', component: VideosComponent },
  { path: 'contact', component: ContactComponent },
  { path: 'shop', component: ShopComponent }
    ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
