import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'CyberOfSale',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44359',
    redirectUri: baseUrl,
    clientId: 'CyberOfSale_App',
    responseType: 'code',
    scope: 'offline_access CyberOfSale',
  },
  apis: {
    default: {
      url: 'https://localhost:44365',
      rootNamespace: 'FRIDAY.CyberOfSale',
    },
  },
} as Environment;
