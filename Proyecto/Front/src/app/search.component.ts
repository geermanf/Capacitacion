import { Component, OnInit } from '@angular/core';

import { Doc } from './Model/Doc';
import { Model } from './Model/Model';

import { NewsService } from './news.service';
import { NewsComponent } from './news.component';


import { Router } from '@angular/router';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent {
  public model = new Model();
  public qError = '';
  public bError = '';
  public eError = '';


  constructor(private router: Router) {}

  gotoNews(): void {
    const arrayBeginDate = this.model.beginDate.toString().split('-');
    const arrayEndDate = this.model.endDate.toString().split('-');

    const beginDayFormat =
      arrayBeginDate[0] + arrayBeginDate[1] + arrayBeginDate[2];
    const endDayFormat = arrayEndDate[0] + arrayEndDate[1] + arrayEndDate[2];

    this.router.navigate([
      '/news',
      this.model.q,
      beginDayFormat,
      endDayFormat
    ]);
  }

  isValidDate(): boolean {
    if (this.model.beginDate <= this.model.endDate) {
      return true;
    } else {
      return false;
    }
  }

  validateQ(): void {
    if ((this.model.q == null) || (this.model.q === '')) {
      this.qError = 'Se requiere palabra clave';
    } else {
      this.qError = '';
    }
  }
  validateBegin(): void {
    if ((this.model.beginDate == null) || (this.model.beginDate.toString() === '')) {
      this.bError = 'Se requiere fecha de inicio';
    } else {
      this.bError = '';
    }
  }
  validateEnd(): void {
    if ((this.model.endDate == null) || (this.model.endDate.toString() === '')) {
      this.eError = 'Se requiere fecha de fin';
    } else {
      this.eError = '';
    }
  }

}
