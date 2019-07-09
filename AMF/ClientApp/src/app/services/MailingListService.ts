
import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Observable } from "rxjs";

@Injectable()
export class MailingListService
{
  constructor(private httpClient: HttpClient) {


  }

  getSubscriber(): Observable<any> {

    return this.httpClient.get("//localhost:47294/api/mailingList/mailList")

  }

  }

