import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'sites',
    loadChildren: () => import('./sites/sites.module').then(m=>m.SitesModule)
  },
  {
    path: 'pumps',
    loadChildren: () => import('./pumps/pumps.module').then(m=>m.PumpsModule)
  },
  {
    path: 'receipts',
    loadChildren: () => import('./receipts/receipts.module').then(m=>m.ReceiptsModule)
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
