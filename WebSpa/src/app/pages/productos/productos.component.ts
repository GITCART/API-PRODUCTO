import { Component, OnInit } from '@angular/core';
import { ProductoService } from '../../services/producto.service';
import { Producto } from '../../models/produto';
import { Router } from '@angular/router';

@Component({
  selector: 'app-productos',
  templateUrl: './productos.component.html',
  styleUrls: ['./productos.component.css']
})
export class ProductosComponent implements OnInit {

  productos: Producto[] = [];
  cargando = false;
  error = false;

  constructor(private productoService: ProductoService,
              private router: Router) {
  }

  ngOnInit(): void {
    this.cargando = true;

    this.productoService.getProductos().subscribe((data: Producto[]) => {
      this.productos = data;

      this.cargando = false;
    }, (err) => {
      if (err !== null) {
        this.error = true;
        this.cargando = false;
      }
    });
  }

  verProducto(id: number){
    this.router.navigate(['/producto', id]);
  }

}
