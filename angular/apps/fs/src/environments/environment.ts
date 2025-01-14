import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Demo',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44326',
    redirectUri: baseUrl,
    clientId: 'Demo_App',
    responseType: 'password',
    scope: 'offline_access openid profile role email phone Demo',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44326',
      rootNamespace: '',
    },
  },
} as Environment;
