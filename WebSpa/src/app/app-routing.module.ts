import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProductosComponent } from './pages/productos/productos.component';
import { ProductoComponent } from './pages/producto/producto.component';


const routes: Routes = [
  {path: 'productos', component: ProductosComponent},
  {path: 'producto/:id', component: ProductoComponent},
  {path: '**', pathMatch: 'full', redirectTo: 'productos'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
