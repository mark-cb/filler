import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PumpListComponent } from './pump-list/pump-list.component';
import { PumpsRoutingModule } from './pumps-routing.module';



@NgModule({
  declarations: [
    PumpListComponent
  ],
  imports: [
    CommonModule,
    PumpsRoutingModule
  ]
})
export class PumpsModule { }
