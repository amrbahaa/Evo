import { Injectable } from '@angular/core';
import { Http, Jsonp, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class KpiService {

  kpiDataFileUrl = '/assets/data/kpis.json';
  positionsDataFileUrl = '/assets/data/positions.json';

  constructor(private http: Http) { }

  getKpiGroups() {
    return this.http.get(this.kpiDataFileUrl)
      .map(resp => {
        return resp.json();
      })
      .catch(this.handleError);
  }

  getWorkPositions() {
    return this.http.get(this.positionsDataFileUrl)
      .map(resp => {
        return resp.json();
      })
      .catch(this.handleError);
  }

  handleError(error: Response) {
    return Observable.throw(error);
  }
}
