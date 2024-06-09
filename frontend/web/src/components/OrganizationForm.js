/* src/components/OrganizationForm.js */

// Package Block
import { useState, useEffect } from 'react';
import { Spin } from 'antd';
import { CustomStates } from '../utils/constant';
// Custom Components and functions Block
import { InputField, Button } from '../components';
import { getAllStates } from '../services/states';

const OrganizationForm = ({ formData, handleInputChange, handleSubmit }) => {
  const [loader, setLoader] = useState(false);
  const [states, setStates] = useState(CustomStates);

  // Getting Data of Counties & States
  const getStates = async () => {
    setLoader(true);
    try {
      const response = await getAllStates();
      setStates(response?.data?.data);
      setLoader(false);
    } catch (error) {
      console.log('🚀 ~ getStates ~ error:', error);
      setLoader(false);
    }
  };

  useEffect(() => {
    getStates();
  }, []);

  return (
    <Spin spinning={loader}>
      <form onSubmit={handleSubmit}>
        <h3 className="form-subtitle">
          {formData.roleId === 'manufacturer'
            ? 'Manufacturer Organization Information'
            : 'Dispensary Organization Information'}
        </h3>
        <p className="form-subtitle">Business Details</p>
        <p className="form-subtitle">
          This information will be used for identification verification.
        </p>
        <div className="input-pair">
          <InputField
            type="text"
            placeholder="Legal Business Name"
            name="businessName"
            value={formData.businessName}
            onChange={handleInputChange}
          />
          <InputField
            type="text"
            placeholder="EIN # (12-1234567)"
            name="businessEIN"
            value={formData.businessEIN}
            onChange={handleInputChange}
          />
        </div>
        <div className="input-pair">
          <InputField
            type="text"
            placeholder="Business Phone"
            name="businessContact"
            value={formData.businessContact}
            onChange={handleInputChange}
          />
          <InputField
            type="email"
            placeholder="Business Email"
            name="businessEmail"
            value={formData.businessEmail}
            onChange={handleInputChange}
          />
        </div>
        <div className="input-pair">
          <InputField
            type="text"
            placeholder="Business Address"
            name="businessAddress"
            value={formData.businessAddress}
            onChange={handleInputChange}
          />
          <InputField
            type="text"
            placeholder="Business City"
            name="businessCity"
            value={formData.businessCity}
            onChange={handleInputChange}
          />
        </div>
        <div className="input-pair">
          <select
            name="businessState"
            value={formData.businessState}
            onChange={handleInputChange}
            className="select-field"
          >
            <option value="">Select State</option>
            {states?.map((state, index) => (
              <option key={index} value={state?.id}>
                {state?.name}
              </option>
            ))}
          </select>
          <InputField
            type="text"
            placeholder="Business Zip Code"
            name="businessZipCode"
            value={formData.businessZipCode}
            onChange={handleInputChange}
          />
        </div>
        <Button type="submit" className="button">
          Continue
        </Button>
      </form>
    </Spin>
  );
};

export default OrganizationForm;
