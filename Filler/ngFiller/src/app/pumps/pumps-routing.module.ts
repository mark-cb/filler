import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PumpListComponent } from './pump-list/pump-list.component';

const routes: Routes = [
{
  path: '',
  component: PumpListComponent
}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PumpsRoutingModule { }
