import { TestBed, inject } from '@angular/core/testing';

import { KpiService } from './kpi.service';

describe('KpiServiceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [KpiService]
    });
  });

  it('should be created', inject([KpiService], (service: KpiService) => {
    expect(service).toBeTruthy();
  }));
});
