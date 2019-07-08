import { MailingList } from "../dtos/MailingList";
import { Injectable } from "@angular/core";
import { HttpClient } from "selenium-webdriver/http";

@Injectable()
export class MailingListService
{
  constructor(private httpClient: HttpClient) {


  }
  public AddMail(emailAddress: string, firstName: string, lastName: string, dobDay: number, dobMonth: number, dobYear: number): void {

    let subscription: MailingList = new MailingList();

    subscription.new();

    subscription.emailAddress = emailAddress;
    subscription.firstName = firstName;
    subscription.lastName = lastName;
    subscription.dobDay = dobDay;
    subscription.dobMonth = dobMonth;
    subscription.dobYear = dobYear;

   


  }

}
