import 'rxjs/add/operator/switchMap';
import { Component, OnInit, Input } from '@angular/core';
// import { RootObject} from "./Model/RootObject";
import { Doc } from './Model/Doc';
import { NewsService } from './news.service';
import { ActivatedRoute, ParamMap, Params } from '@angular/router';

@Component({
  selector: 'app-news',
  templateUrl: './news.component.html',
  styleUrls: ['./news.component.css']
})
export class NewsComponent implements OnInit {
  news: Doc[];
  q: string;
  beginDate: string;
  endDate: string;
  urlState: boolean;

  constructor(private newsService: NewsService, private route: ActivatedRoute) {}

   ngOnInit(): void {
   this.urlState = false;

   this.route.paramMap
     .switchMap((params: ParamMap) => this.newsService
     .getNews(params.get('q'), +params.get('beginDate'), +params.get('endDate')))
     .subscribe((news: Doc[]) => this.news = news);
  }

  showUrl(): void {
    if (this.urlState === true) {
      this.urlState = false;
    } else {
      this.urlState = true;
    }
  }

}
