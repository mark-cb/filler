import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ReceiptsRoutingModule } from './receipts-routing.module';
import { ReceiptListComponent } from './receipt-list/receipt-list.component';


@NgModule({
  declarations: [
    ReceiptListComponent
  ],
  imports: [
    CommonModule,
    ReceiptsRoutingModule
  ]
})
export class ReceiptsModule { }
