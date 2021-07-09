const ENV = {
  dev: {
    apiUrl: 'http://localhost:44365',
    oAuthConfig: {
      issuer: 'http://localhost:44359',
      clientId: 'CyberOfSale_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access CyberOfSale',
    },
    localization: {
      defaultResourceName: 'CyberOfSale',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44365',
    oAuthConfig: {
      issuer: 'http://localhost:44359',
      clientId: 'CyberOfSale_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access CyberOfSale',
    },
    localization: {
      defaultResourceName: 'CyberOfSale',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
