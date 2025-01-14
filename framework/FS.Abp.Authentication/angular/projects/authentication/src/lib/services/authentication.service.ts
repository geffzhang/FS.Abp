import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class AuthenticationService {
  apiName = 'Authentication';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/Authentication/sample' },
      { apiName: this.apiName }
    );
  }
}
