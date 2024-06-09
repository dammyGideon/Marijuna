/* src/components/CompletionStep.js */

// Package Block
import React from 'react';
import { Link } from 'react-router-dom';

const CompletionStep = () => {
  return (
    <div className="completion-step">
      <h2 className="completion-subtitle">Onboarding Complete!</h2>
      <p className="completion-message">
        Thank you for completing the onboarding. Please check your email for
        account setup confirmation.
      </p>
      <Link to="/dashboard" className="completion-button">
        Continue to Dashboard
      </Link>
    </div>
  );
};

export default CompletionStep;
