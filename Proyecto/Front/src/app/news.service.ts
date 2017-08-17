import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Location } from '@angular/common';

import 'rxjs/add/operator/toPromise';

import { Doc } from './Model/Doc';

@Injectable()
export class NewsService {

  private headers = new Headers({'Content-Type': 'application/json'});

  constructor(private http: Http) { }

  getNews(q: string, beginDate: number, endDate: number): Promise<Doc[]> {
    let url: string;
    url = `http://localhost:5000/api/news?q=/${q}&begindate=${beginDate}&enddate=${endDate}`;
    return this.http.get(url)
               .toPromise()
               .then(response => response.json())
               .catch(this.handleError);
  }

  private handleError(error: any): Promise<any> {
    console.error('An error occurred', error); // for demo purposes only
    return Promise.reject(error.message || error);
  }
}

