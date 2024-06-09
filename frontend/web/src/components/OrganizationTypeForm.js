/* src/components/OrganizationTypeForm.js */
// Package Block
import { useEffect, useState } from 'react';
import { Spin } from 'antd';

// Custom Component Block
import { CustomOrganizationType } from '../utils/constant';
import { Button } from './index';
import { getOrganizationType } from '../services/organizationType';

const OrganizationTypeForm = ({
  handleSubmit,
  handleInputChange,
  formData,
}) => {
  const [organizationsType, setOrganizationsType] = useState(
    CustomOrganizationType
  );
  const [loader, setLoader] = useState(false);
  const getCustomOrganizationTypes = async () => {
    try {
      setLoader(true);
      const response = await getOrganizationType();
      setOrganizationsType(response.data);
      setLoader(false);
    } catch (error) {
      console.log('🚀 ~ getCustomOrganizationTypes ~ error:', error);
      setLoader(false);
    }
  };

  useEffect(() => {
    getCustomOrganizationTypes();
  }, []);
  return (
    <Spin spinning={loader}>
      <form onSubmit={handleSubmit}>
        <select
          value={formData.roleId}
          onChange={handleInputChange}
          required
          className="select-field"
          name="roleId"
        >
          <option value="" disabled>
            Select...
          </option>
          {organizationsType.map(({ value, name }) => (
            <option value={value} key={value}>
              {name}
            </option>
          ))}
        </select>
        <Button className="button" type="submit">
          Continue
        </Button>
      </form>
    </Spin>
  );
};

export default OrganizationTypeForm;
