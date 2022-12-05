import { Component, OnInit } from '@angular/core';
import { Subject, takeUntil } from 'rxjs';
import { Site } from 'src/app/models/site';
import { WebapiService } from 'src/app/services/webapi.service';

@Component({
  selector: 'app-site-list',
  templateUrl: './site-list.component.html',
  styleUrls: ['./site-list.component.scss']
})
export class SiteListComponent implements OnInit {
  destroy$: Subject<boolean> = new Subject<boolean>();
  siteData: Site[] = [];

  constructor(public api: WebapiService) { }

  ngOnInit(): void {
    this.api.findAllSites().subscribe(data => {
      this.siteData = data;
    })

  }
}
