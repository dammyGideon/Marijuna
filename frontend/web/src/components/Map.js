// Package Block
import React, { useEffect, useRef, useState } from 'react';

// Get API key
import { apiKey } from '../config'; // Adjust the import path as needed

const Map = () => {
  const mapRef = useRef(null);
  const [isLoaded, setIsLoaded] = useState(false);
  const [error, setError] = useState(null);

  useEffect(() => {
    const loadGoogleMapsAPI = () => {
      return new Promise((resolve, reject) => {
        if (window.google && window.google.maps) {
          resolve();
          return;
        }

        const existingScript = document.getElementById('google-maps-script');
        if (existingScript) {
          existingScript.onload = () => resolve();
          existingScript.onerror = () =>
            reject('Failed to load Google Maps API');
          return;
        }

        const script = document.createElement('script');
        script.id = 'google-maps-script';
        script.src = `https://maps.googleapis.com/maps/api/js?key=${apiKey}`;
        script.async = true;
        script.defer = true;
        script.onload = () => resolve();
        script.onerror = () => reject('Failed to load Google Maps API');
        document.head.appendChild(script);
      });
    };

    loadGoogleMapsAPI()
      .then(() => setIsLoaded(true))
      .catch((err) => setError(err));
  }, []);

  useEffect(() => {
    if (isLoaded && !error) {
      try {
        const google = window.google;
        const map = new google.maps.Map(mapRef.current, {
          center: { lat: 38.627, lng: -90.1994 }, // Centered on St. Louis
          zoom: 10,
        });
        console.log('object', map);
      } catch (err) {
        setError('Failed to initialize Google Maps');
      }
    }
  }, [isLoaded, error]);

  return (
    <div>
      {error ? (
        <div className="map-error">{error}</div>
      ) : (
        <div
          className="map"
          ref={mapRef}
          style={{ height: '100vh', width: '100%' }}
        ></div>
      )}
    </div>
  );
};

export default Map;
