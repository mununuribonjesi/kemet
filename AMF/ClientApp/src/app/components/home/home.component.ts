import { Component, OnInit } from '@angular/core';
import { MailingListService } from 'src/app/services/MailingListService';
import { subscribers } from 'src/app/dtos/Subscribers';
import { countries } from 'src/app/dtos/Countries';
import { Guid } from "guid-typescript";
import { create } from 'domain';
import { subscribedEmails } from 'src/app/dtos/subscribedEmails';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  isMailLst: boolean = false;
  countryList: string[];
  monthList: string[];
  dayList: string[];
  yearList: any[];
  genderList: string[];
  lstSubscribers: subscribers[];
  lstCountries: countries[];
  firstName: string;
  LastName: string;
  gender: string;
  day: number;
  month: number;
  year: number;
  email: string;
  postCode: string;
  country: string;
  city: string;
  objSubscribers: subscribers;
  objSubscribedEmails = subscribedEmails;


  constructor(private _mailingListService: MailingListService) {

  }

  ngOnInit() {
    this.monthList = ["01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"];
    this.dayList = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"];
    this.yearList = this.getRangeOfYears();
    this.genderList = ["Unspecified", "Male", "Female"];
    

    this._mailingListService.getCountries().subscribe(
      data => {
        this.lstCountries = data;
      }
    );

  }


  joinMailing() {
    this.isMailLst = !this.isMailLst;
  }

  getRangeOfYears() {
    var currentYear = new Date().getFullYear();
    var yearRange = [];
    var i = 0;
    while (i <= 120) {
      yearRange.push(currentYear - i)
      i++
    }
    return yearRange;
  }

  subscribe() {

    var subscription = new subscribers();
    var subscriptionEmail = new subscribedEmails();

    var emailID = Guid.create();
    var subscriptionID = Guid.create();

    subscription.birthDate = new Date(this.year, this.month, this.day);
    subscription.city = this.city;
    subscription.countryID = this.country;
    subscription.emailID = emailID.toString();
    subscription.firstName = this.firstName;
    subscription.gender = this.gender;
    subscription.lastName = this.LastName;
    subscription.PostCode = this.postCode;
    subscription.subscriptionID = subscriptionID.toString();

    subscriptionEmail.email = this.email;
    subscriptionEmail.emailID = emailID.toString();

    this._mailingListService.postSubscriber(subscription).subscribe(
      data => {
        this.objSubscribers = data;
      }
    );


    this._mailingListService.postEmail(subscriptionEmail).subscribe(
      data => {
        this.objSubscribedEmails = data;
      }
    );
  }

  }

