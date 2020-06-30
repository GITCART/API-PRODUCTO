import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProductoService } from '../../services/producto.service';
import { Producto } from '../../models/produto';

@Component({
  selector: 'app-producto',
  templateUrl: './producto.component.html',
  styleUrls: ['./producto.component.css']
})
export class ProductoComponent implements OnInit {

  producto: Producto;

  cargando = false;
  error = false;

  constructor(private productoService: ProductoService, private activateRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.cargando = true;
    const id = this.activateRoute.snapshot.paramMap.get('id');

    this.productoService.getProducto(Number(id)).subscribe((data: Producto) => {
      this.producto = data;

      this.cargando = false;
    }, (err) => {

      if (err !== null) {
        this.error = true;
        this.cargando = false;
      }
    });
  }

}
