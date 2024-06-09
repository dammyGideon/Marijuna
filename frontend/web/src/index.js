// Package Block
// import { StrictMode } from 'react';
import ReactDOM from 'react-dom/client';

// Styles block
import './styles/index.css';
import './styles/auth.css';
import './styles/onboarding.css';
import './styles/dashboard.css';
import 'antd/dist/reset.css'; // Updated import for Ant Design v5

// App Component
import App from './views/App';

// Configuration
import { apiKey } from './config';

// Utilities
import { loadGoogleMaps } from './utils/googleMaps';

// Load Google Maps
loadGoogleMaps(apiKey);

// Render App
const root = ReactDOM.createRoot(document.getElementById('root'));

root.render(
  // In development, Strict mode render twice for API integration so for now I am gonna remove it
  // <StrictMode>
  <App />
  // </StrictMode>
);
