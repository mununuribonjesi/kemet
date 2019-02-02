import { Component, OnInit } from '@angular/core';
import {VirtualScrollerModule} from 'primeng/virtualscroller';
import {artist} from './../../Interfaces/artist'
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

    public artistInformation: artist[] = [];
    public artistInfo: artist;
  
  constructor() { }

    ngOnInit() 
    {
      
        
         
  
  }

}
