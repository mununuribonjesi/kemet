
import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Observable } from "rxjs";
import { subscribers } from "../dtos/Subscribers";
import { subscribedEmails } from "../dtos/subscribedEmails";


@Injectable()
export class MailingListService {
  constructor(private httpClient: HttpClient) {
  }

  getSubscriber(): Observable<any> {
    return this.httpClient.get("//localhost:47294/api/mailingList/mailList")
  }

  getCountries(): Observable<any> {
    return this.httpClient.get("//localhost:47294/api/countries/getCountries")
  }

  postSubscriber(subscribers: subscribers): Observable<any> {
    return this.httpClient.post("//localhost:47294/api/MailingList/addSubscriber", subscribers);
  }

  postEmail(subscribedEmails: subscribedEmails): Observable<any> {
    return this.httpClient.post("//localhost:47294/api/Email/addEmail", subscribedEmails);
  }
}

