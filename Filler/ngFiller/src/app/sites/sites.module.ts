import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SiteListComponent } from './site-list/site-list.component';
import { SitesRoutingModule } from './sites-routing.module';



@NgModule({
  declarations: [
    SiteListComponent

  ],
  imports: [
    CommonModule,
    SitesRoutingModule
  ]
})
export class SitesModule { }
