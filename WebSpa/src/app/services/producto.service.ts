import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductoService {

  private url = 'https://localhost:44307/api/Producto';

  constructor(private http: HttpClient) { }

  getProductos(){
    return this.http.get(this.url);
  }

  getProducto(id: number){
    return this.http.get(`${this.url}/${id}`);
  }

}
