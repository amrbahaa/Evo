import { Injectable } from '@angular/core';
import { Http, Jsonp, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class KpiService {

  dataFileUrl = '/assets/data/kpis.json'

  constructor(private http: Http) { }

  getKpiGroups() {
    return this.http.get(this.dataFileUrl)
      .map(resp => {
        return resp.json();
      })
      .catch(this.handleError);
  }

  handleError(error: Response) {
    return Observable.throw(error);
  }
}
